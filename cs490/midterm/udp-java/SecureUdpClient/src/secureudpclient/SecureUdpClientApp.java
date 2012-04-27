/*
 * SecureUdpClientApp.java
 */

package secureudpclient;

import org.jdesktop.application.Application;
import org.jdesktop.application.SingleFrameApplication;

/**
 * The main class of the application.
 */
public class SecureUdpClientApp extends SingleFrameApplication {

    /**
     * At startup create and show the main frame of the application.
     */
    @Override protected void startup() {
        show(new SecureUdpClientView(this));
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
     * @return the instance of SecureUdpClientApp
     */
    public static SecureUdpClientApp getApplication() {
        return Application.getInstance(SecureUdpClientApp.class);
    }

    /**
     * Main method launching the application.
     */
    public static void main(String[] args) {
        launch(SecureUdpClientApp.class, args);
    }
}
