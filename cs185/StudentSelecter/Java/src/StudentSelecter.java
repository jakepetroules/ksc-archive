import java.awt.*;
import java.awt.Dialog.*;
import java.awt.event.*;
import java.io.*;
import java.util.*;
import javax.swing.*;
import org.apache.commons.net.ftp.*;
import net.java.games.joal.*;

/**
 * The main window of the student selecter application.
 */
@SuppressWarnings("serial")
public class StudentSelecter extends JFrame
{
    /**
     * The names of the students who may be called upon.
     */
    private ArrayList<String> names = new ArrayList<String>();

    /**
     * The thread used to display the user's name in a delayed manner.
     */
    private Thread delayThread;

    /**
     * Our custom wave player used to play the wave file and keep track of events.
     */
    private WavePlayer player;

    /**
     * The animation controller.
     */
    private SelectionAnimation animation = new SelectionAnimation();

    /**
     * The get name button.
     */
    private ButtonControl getNameButton = new ButtonControl("Get a name");

    /**
     * The configure button.
     */
    private ButtonControl configureButton = new ButtonControl("Configure");

    /**
     * Whether to show the UI buttons.
     */
    private boolean showUI;
    
    /**
     * The back buffer for animation graphics.
     */
    private Image buffer;
    
    /**
     * The graphics object to draw to the back buffer.
     */
	private Graphics2D bufferGraphics;
	
	/**
	 * The last student name that was displayed, used to prevent the same name appearing twice in a row.
	 */
	private String lastName = "";

    /**
     * Initializes a new instance of the {@link StudentSelecter} class.
     */
    public StudentSelecter()
    {
    	this.names.add("NO NAMES LOADED");
    	
    	this.getNameButton.setLocation(new Point(12, 12));
    	
    	Dimension size = new Dimension(850, 450);
    	this.setMinimumSize(size);
	    this.setSize(size);
	    this.setLocationRelativeTo(null);
	    this.setTitle("Student Selecter");
	    
	    File icon = new File("res/app.png");
	    if (icon.exists())
	    {
	    	this.setIconImage(Toolkit.getDefaultToolkit().getImage(icon.getAbsolutePath()));
	    }
	    	    
	    this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	    
	    this.enableEvents(AWTEvent.MOUSE_EVENT_MASK);
    }

    /**
     * The main entry point for the application.
     * @param args The command-line arguments.
     * @throws IOException An I/O error occurs.
     */
    public static void main(String[] args) throws IOException
    {
    	try
		{
			UIManager.setLookAndFeel("com.sun.java.swing.plaf.windows.WindowsLookAndFeel");
		}
		catch (ClassNotFoundException e)
		{
			e.printStackTrace();
		}
		catch (InstantiationException e)
		{
			e.printStackTrace();
		}
		catch (IllegalAccessException e)
		{
			e.printStackTrace();
		}
		catch (UnsupportedLookAndFeelException e)
		{
			e.printStackTrace();
		}
		
		ConfigurationFile.load();
		
        StudentSelecter studentSelecter = new StudentSelecter();
        studentSelecter.setVisible(true);
    }

    /**
     * Performs cleanup operations.
     * @param e The window close event data.
     */
    @Override
    public void processWindowEvent(WindowEvent e)
    {
    	switch (e.getID())
    	{
    		case WindowEvent.WINDOW_OPENED:
    			try
				{
    				File song = new File("res/song-clip.wav");
    				if (song.exists())
    				{
    					this.player = new WavePlayer(song.getAbsolutePath());
    				}
    				else
    				{
    					JOptionPane.showMessageDialog(this, "Failed to load audio data. Program will exit.");
    					this.dispose();
    					return;
    				}
				}
				catch (IOException e1)
				{
					JOptionPane.showMessageDialog(this, e1.toString());
				}
				catch (OpenALException e2)
				{
					JOptionPane.showMessageDialog(this, e2.toString());
				}

    	        // Listen for play state change events
    	        this.player.addSourceStateChangedListener(new SourceStateChangedListener()
    	        {
    				@Override
    				public void sourceStateChanged(SourceStateChangedEvent event)
    				{
    					StudentSelecter.this.player_SourceStateChanged(event);
    				}
    			});
    	        
    	        this.getContentPane().addMouseListener(new MouseListener()
    	        {
					@Override
					public void mouseClicked(MouseEvent arg0)
					{
						if (StudentSelecter.this.showUI)
				        {
				            // Begins the process of generating a new student name
				            if (StudentSelecter.this.getNameButton.getRectangle().contains(arg0.getPoint()) && StudentSelecter.this.getNameButton.isEnabled())
				            {
				                if (StudentSelecter.this.names.size() > 0)
				                {
				                    // Disable the buttons and play the song
				                	StudentSelecter.this.getNameButton.setEnabled(false);
				                	StudentSelecter.this.configureButton.setEnabled(false);
				                	StudentSelecter.this.player.play();
				                }
				                else
				                {
				                    JOptionPane.showMessageDialog(StudentSelecter.this, "There are no names to select from. Please make sure you have an active Internet connection and FTP server configured.");
				                }
				            }
				
				            // Launches the configuration dialog
				            if (StudentSelecter.this.configureButton.getRectangle().contains(arg0.getPoint()) && StudentSelecter.this.configureButton.isEnabled())
				            {
				                OptionsDialog dialog = new OptionsDialog();
				                dialog.setModalityType(ModalityType.TOOLKIT_MODAL);
				                dialog.setVisible(true);
				                {
				                    StudentSelecter.this.loadNames();
				                }
				            }
				        }
					}

					@Override
					public void mouseEntered(MouseEvent arg0)
					{
						// Shows the buttons when the mouse enters the window.
						StudentSelecter.this.showUI = true;
					}

					@Override
					public void mouseExited(MouseEvent arg0)
					{
						// Hides the buttons when the mouse leaves the window.
		    			StudentSelecter.this.showUI = false;
					}

					@Override
					public void mousePressed(MouseEvent arg0)
					{
					}

					@Override
					public void mouseReleased(MouseEvent arg0)
					{
					}
    	        });

    	        // Load the student names into the program
    	        this.loadNames();
    	        
    	        break;
    		case WindowEvent.WINDOW_CLOSING:
    			this.player.dispose();
    			System.exit(0);
    			break;
    	}
    }

    /**
     * Paints the animation onto the GUI.
     * @param g The graphics context used to draw the animation.
     */
    @Override
    public void paint(Graphics g)
    {
    	this.checkBuffer();
    	
        this.animation.paint(this.bufferGraphics, this.getContentPane().getBounds());

        this.configureButton.setLocation(new Point(this.getContentPane().getBounds().width - this.configureButton.getSize().width - 12, 12));

        if (this.showUI)
        {
            this.getNameButton.draw(this.bufferGraphics);
            this.configureButton.draw(this.bufferGraphics);
        }
        
        try
		{
			Thread.sleep(10);
		}
		catch (InterruptedException e)
		{
			e.printStackTrace();
		}
		
		((Graphics2D)this.getContentPane().getGraphics()).drawImage(this.buffer, 0, 0, this);
        this.repaint();
    }

    /**
     * Notifies the animation controller and updates the UI on player source state changes.
     * @param event The event data.
     */
    private void player_SourceStateChanged(SourceStateChangedEvent event)
    {
        this.animation.setSourceState(this.player.getSourceState());

        switch (this.player.getSourceState())
        {
            case PLAYING:
                // Set the current user to nothing and invoke the delay thread
                this.animation.setCurrentUser("");
                this.delayThread = new Thread(new Runnable()
                {
					@Override
					public void run()
					{
						StudentSelecter.this.generateNameWithDelay();
					}
				});
                
                this.delayThread.start();
                break;
            case STOPPED:
                // Enable the buttons for another try
                this.getNameButton.setEnabled(true);
                this.configureButton.setEnabled(true);
                break;
        }
    }
    
    /**
     * Checks if the back buffer needs to be resized and does so if needed.
     */
    public void checkBuffer()
    {
    	Container contentPane = this.getContentPane();
    	if (this.buffer == null || (this.buffer.getWidth(this) != contentPane.getWidth() || this.buffer.getHeight(this) != contentPane.getHeight()))
    	{
    		this.createBuffer();
    	}
    }
    
    /**
	 * Creates (or recreates) the back buffer for animation drawing.
	 */
	public void createBuffer()
	{
		this.buffer = this.createImage(this.getContentPane().getWidth(), this.getContentPane().getHeight());
		this.bufferGraphics = (Graphics2D)buffer.getGraphics();
	}

    /**
     * Loads the student names from the remote server into the program.
     */
    private void loadNames()
    {
    	try
		{
    		FTPClient c = new FTPClient();
    		c.connect(ConfigurationFile.getHost());
    		c.login(ConfigurationFile.getUsername(), ConfigurationFile.getPassword());
        	InputStream stream = c.retrieveFileStream(ConfigurationFile.getPath());
    		
    		StringBuilder builder = new StringBuilder();
    		int data;
    		while ((data = stream.read()) > -1)
    		{
    			builder.append((char)data);
    		}
    		
    		this.names.clear();
    		String[] names = builder.toString().split("\r\n");
    		for (int i = 0; i < names.length; i++)
    		{
    			this.names.add(names[i]);
    		}
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}
    }

    /**
     * Waits 8 seconds and then generates a student name.
     */
    private void generateNameWithDelay()
    {
        try
		{
			Thread.sleep(500);
		}
		catch (InterruptedException e)
		{
			e.printStackTrace();
		}
		
		String name = "";
		do
		{
			name = this.names.get(new RandomExtensions().generateIndex(this.names.size()));
		}
		while (name.equals(this.lastName));
		
		this.animation.setCurrentUser(name);
		this.lastName = name;
    }
}