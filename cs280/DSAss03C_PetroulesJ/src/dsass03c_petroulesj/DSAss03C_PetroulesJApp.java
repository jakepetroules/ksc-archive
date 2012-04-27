/*
 * DSAss03C_PetroulesJApp.java
 */

package dsass03c_petroulesj;

import org.jdesktop.application.Application;
import org.jdesktop.application.SingleFrameApplication;

/**
 * The main class of the application.
 */
public class DSAss03C_PetroulesJApp extends SingleFrameApplication {

    /**
     * At startup create and show the main frame of the application.
     */
    @Override protected void startup() {
        show(new DSAss03C_PetroulesJView(this));
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
     * @return the instance of DSAss03C_PetroulesJApp
     */
    public static DSAss03C_PetroulesJApp getApplication() {
        return Application.getInstance(DSAss03C_PetroulesJApp.class);
    }

    /**
     * Main method launching the application.
     */
    public static void main(String[] args) {
        launch(DSAss03C_PetroulesJApp.class, args);
    }
}
