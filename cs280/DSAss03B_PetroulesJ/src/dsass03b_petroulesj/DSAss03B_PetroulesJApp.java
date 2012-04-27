/*
 * DSAss03B_PetroulesJApp.java
 */

package dsass03b_petroulesj;

import org.jdesktop.application.Application;
import org.jdesktop.application.SingleFrameApplication;

/**
 * The main class of the application.
 */
public class DSAss03B_PetroulesJApp extends SingleFrameApplication {

    /**
     * At startup create and show the main frame of the application.
     */
    @Override protected void startup() {
        show(new DSAss03B_PetroulesJView(this));
    }

    /**
     * This method is to initialize the specified window by injecting resources.
     * Windows shown in our application come fully initialized from the GUI
     * builder, so this additional configuration is not needed.
     */
    @Override protected void configureWindow(java.awt.Window root) {
    }

    /**
     * A convenient static getter for the application instance.
     * @return the instance of DSAss03B_PetroulesJApp
     */
    public static DSAss03B_PetroulesJApp getApplication() {
        return Application.getInstance(DSAss03B_PetroulesJApp.class);
    }

    /**
     * Main method launching the application.
     */
    public static void main(String[] args) {
        launch(DSAss03B_PetroulesJApp.class, args);
    }
}
