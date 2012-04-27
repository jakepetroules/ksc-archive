import java.awt.event.*;
import java.io.*;
import javax.swing.*;
import org.apache.commons.net.ftp.*;

/**
 * Represents the Student Selecter options dialog.
 */
@SuppressWarnings("serial")
public class OptionsDialog extends JDialog
{
	private JPanel groupBox = new JPanel();
	private JLabel hostLabel = new JLabel("Host:");
	private JTextField hostField = new JTextField(ConfigurationFile.getHost(), 30);
	private JLabel pathLabel = new JLabel("Path:");
	private JTextField pathField = new JTextField(ConfigurationFile.getPath(), 30);
	private JLabel usernameLabel = new JLabel("Username:");
	private JTextField usernameField = new JTextField(ConfigurationFile.getUsername(), 27);
	private JLabel passwordLabel = new JLabel("Password:");
	private JPasswordField passwordField = new JPasswordField(ConfigurationFile.getPassword(), 27);
	private JCheckBox showCharacters = new JCheckBox("Show characters");
	private JButton loadButton = new JButton("Load");
	private JTextArea textBox = new JTextArea();
	private JButton buttonOK = new JButton("OK");
	private JButton buttonCancel = new JButton("Cancel");
	
	/**
	 * Initializes a new instance of the {@link OptionsDialog} class.
	 */
	public OptionsDialog()
	{
		this.setLayout(null);

		this.setSize(600, 389);
		this.setResizable(false);
		this.setLocationRelativeTo(null);
		this.setTitle("Options");
		
		this.groupBox.setLocation(12, 12);
		this.groupBox.setSize(300, 175);
		this.groupBox.setBorder(BorderFactory.createTitledBorder("Data location"));
		this.add(this.groupBox);
		
		this.groupBox.add(this.hostLabel);
		this.groupBox.add(this.hostField);
		this.groupBox.add(this.pathLabel);
		this.groupBox.add(this.pathField);
		this.groupBox.add(this.usernameLabel);
		this.groupBox.add(this.usernameField);
		this.groupBox.add(this.passwordLabel);
		this.groupBox.add(this.passwordField);
		this.groupBox.add(this.showCharacters);
		
		this.loadButton.setSize(75, 23);
		this.groupBox.add(this.loadButton);
		
		this.showCharacters.addItemListener(new ItemListener()
		{
			@Override
			public void itemStateChanged(ItemEvent arg0)
			{
				OptionsDialog.this.passwordField.setEchoChar(OptionsDialog.this.showCharacters.isSelected() ? '\0' : '*');
			}
		});
		
		this.loadButton.addMouseListener(new LoadButtonMouseAdapter());
		
		this.passwordField.setEchoChar('*');
		
		this.textBox.setLocation(318, 12);
		this.textBox.setSize(264, 337);
		this.textBox.setEnabled(false);
		this.add(this.textBox);
		
		this.buttonOK.setLocation(12, 326);
		this.buttonOK.setSize(75, 23);
		this.add(this.buttonOK);
		
		this.buttonCancel.setLocation(93, 326);
		this.buttonCancel.setSize(75, 23);
		this.add(this.buttonCancel);
		
		this.buttonOK.addMouseListener(new OKButtonMouseAdapter());
		this.buttonCancel.addMouseListener(new CancelButtonMouseAdapter());
		
		this.addWindowListener(new WindowListener()
		{
			@Override
			public void windowActivated(WindowEvent arg0)
			{
			}

			@Override
			public void windowClosed(WindowEvent arg0)
			{
				OptionsDialog.this.dispose();
			}

			@Override
			public void windowClosing(WindowEvent arg0)
			{
			}

			@Override
			public void windowDeactivated(WindowEvent arg0)
			{
			}

			@Override
			public void windowDeiconified(WindowEvent arg0)
			{
			}

			@Override
			public void windowIconified(WindowEvent arg0)
			{
			}

			@Override
			public void windowOpened(WindowEvent arg0)
			{
				OptionsDialog.this.loadNames();
			}
		});
	}
	
	/**
	 * Loads data from the server into the text box.
	 */
    private void loadNames()
    {
    	try
		{
    		FTPClient c = new FTPClient();
    		c.connect(this.hostField.getText());
    		c.login(this.usernameField.getText(), new String(this.passwordField.getPassword()));
        	InputStream stream = c.retrieveFileStream(this.pathField.getText());
    		
    		StringBuilder builder = new StringBuilder();
    		int data;
    		while ((data = stream.read()) > -1)
    		{
    			builder.append((char)data);
    		}
    		
    		this.textBox.setText(builder.toString());
    		this.textBox.setEnabled(true);
		}
		catch (IOException e)
		{
			this.textBox.setEnabled(false);
			e.printStackTrace();
		}
    }
    
    /**
     * Saves data from the text box onto the server.
     */
    private void saveNames()
    {
    	try
    	{
	    	FTPClient c = new FTPClient();
	    	c.connect(this.hostField.getText());
    		c.login(this.usernameField.getText(), new String(this.passwordField.getPassword()));
	    	OutputStream stream = c.storeFileStream(this.pathField.getText());
	    	stream.write(this.textBox.getText().getBytes());
	    	stream.flush();
	    	stream.close();
	    	this.dispose();
    	}
    	catch (IOException e)
    	{
    		this.textBox.setEnabled(false);
    		int result = JOptionPane.showConfirmDialog(this, "Error: " + e.getMessage(), "Error", JOptionPane.OK_CANCEL_OPTION);
    		switch (result)
    		{
    			case JOptionPane.OK_OPTION:
    				this.dispose();
    				break;
    		}
    		
    		e.printStackTrace();
    	}
    }
	
	class LoadButtonMouseAdapter extends MouseAdapter
	{
		@Override
		public void mouseClicked(MouseEvent arg0)
		{
			OptionsDialog.this.loadNames();
		}
	}
	
	class OKButtonMouseAdapter extends MouseAdapter
	{
		@Override
		public void mouseClicked(MouseEvent arg0)
		{
			OptionsDialog.this.saveNames();
		}
	}
	
	class CancelButtonMouseAdapter extends MouseAdapter
	{
		@Override
		public void mouseClicked(MouseEvent arg0)
		{
			OptionsDialog.this.dispose();
		}
	}
}
