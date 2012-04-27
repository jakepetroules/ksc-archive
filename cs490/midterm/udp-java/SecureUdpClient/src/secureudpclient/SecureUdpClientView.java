/*
 * SecureUdpClientView.java
 */

package secureudpclient;

import cryptolibrary.DatabaseCrypto;
import cryptolibrary.EncryptedData;
import java.net.SocketException;
import java.net.UnknownHostException;
import java.util.logging.Level;
import java.util.logging.Logger;
import org.jdesktop.application.Action;
import org.jdesktop.application.ResourceMap;
import org.jdesktop.application.SingleFrameApplication;
import org.jdesktop.application.FrameView;
import org.jdesktop.application.TaskMonitor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.InetAddress;
import javax.swing.Timer;
import javax.swing.Icon;
import javax.swing.JDialog;
import javax.swing.JFrame;

/**
 * The application's main frame.
 */
public class SecureUdpClientView extends FrameView {
    
    DatagramSocket socket;

    public SecureUdpClientView(SingleFrameApplication app) {
        super(app);
        
        initComponents();
        
        try
        {
            this.socket = new DatagramSocket();
        }
        catch (SocketException ex)
        {
            Logger.getLogger(SecureUdpClientView.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    /** This method is called from within the constructor to
     * initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is
     * always regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        mainPanel = new javax.swing.JPanel();
        addressLabel = new javax.swing.JLabel();
        addressTextField = new javax.swing.JTextField();
        portSpinner = new javax.swing.JSpinner();
        portLabel = new javax.swing.JLabel();
        passphraseLabel = new javax.swing.JLabel();
        passphrasePasswordField = new javax.swing.JPasswordField();
        plaintextLabel = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        plaintextTextArea = new javax.swing.JTextArea();
        sendButton = new javax.swing.JButton();

        mainPanel.setName("mainPanel"); // NOI18N

        org.jdesktop.application.ResourceMap resourceMap = org.jdesktop.application.Application.getInstance(secureudpclient.SecureUdpClientApp.class).getContext().getResourceMap(SecureUdpClientView.class);
        addressLabel.setText(resourceMap.getString("addressLabel.text")); // NOI18N
        addressLabel.setName("addressLabel"); // NOI18N

        addressTextField.setText(resourceMap.getString("addressTextField.text")); // NOI18N
        addressTextField.setName("addressTextField"); // NOI18N

        portSpinner.setModel(new javax.swing.SpinnerNumberModel(45454, 0, 65535, 1));
        portSpinner.setName("portSpinner"); // NOI18N

        portLabel.setText(resourceMap.getString("portLabel.text")); // NOI18N
        portLabel.setName("portLabel"); // NOI18N

        passphraseLabel.setText(resourceMap.getString("passphraseLabel.text")); // NOI18N
        passphraseLabel.setName("passphraseLabel"); // NOI18N

        passphrasePasswordField.setText(resourceMap.getString("passphrasePasswordField.text")); // NOI18N
        passphrasePasswordField.setName("passphrasePasswordField"); // NOI18N

        plaintextLabel.setText(resourceMap.getString("plaintextLabel.text")); // NOI18N
        plaintextLabel.setName("plaintextLabel"); // NOI18N

        jScrollPane1.setName("jScrollPane1"); // NOI18N

        plaintextTextArea.setColumns(20);
        plaintextTextArea.setRows(5);
        plaintextTextArea.setName("plaintextTextArea"); // NOI18N
        jScrollPane1.setViewportView(plaintextTextArea);

        sendButton.setText(resourceMap.getString("sendButton.text")); // NOI18N
        sendButton.setName("sendButton"); // NOI18N
        sendButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                sendButtonActionPerformed(evt);
            }
        });

        org.jdesktop.layout.GroupLayout mainPanelLayout = new org.jdesktop.layout.GroupLayout(mainPanel);
        mainPanel.setLayout(mainPanelLayout);
        mainPanelLayout.setHorizontalGroup(
            mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(mainPanelLayout.createSequentialGroup()
                .addContainerGap()
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.TRAILING)
                    .add(addressLabel)
                    .add(mainPanelLayout.createSequentialGroup()
                        .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.TRAILING)
                            .add(portLabel)
                            .add(passphraseLabel)
                            .add(plaintextLabel))
                        .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED)))
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
                    .add(sendButton)
                    .add(jScrollPane1, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 296, Short.MAX_VALUE)
                    .add(addressTextField, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 296, Short.MAX_VALUE)
                    .add(portSpinner, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(passphrasePasswordField, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 296, Short.MAX_VALUE))
                .addContainerGap())
        );
        mainPanelLayout.setVerticalGroup(
            mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
            .add(mainPanelLayout.createSequentialGroup()
                .addContainerGap()
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(addressTextField, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(addressLabel))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.UNRELATED)
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.TRAILING)
                    .add(portSpinner, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(portLabel))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.UNRELATED)
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.BASELINE)
                    .add(passphrasePasswordField, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, org.jdesktop.layout.GroupLayout.PREFERRED_SIZE)
                    .add(passphraseLabel))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED)
                .add(mainPanelLayout.createParallelGroup(org.jdesktop.layout.GroupLayout.LEADING)
                    .add(plaintextLabel)
                    .add(jScrollPane1, org.jdesktop.layout.GroupLayout.DEFAULT_SIZE, 107, Short.MAX_VALUE))
                .addPreferredGap(org.jdesktop.layout.LayoutStyle.RELATED)
                .add(sendButton)
                .addContainerGap())
        );

        setComponent(mainPanel);
    }// </editor-fold>//GEN-END:initComponents

    private void sendButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_sendButtonActionPerformed
        try {
            EncryptedData data = DatabaseCrypto.encrypt(String.valueOf(this.passphrasePasswordField.getPassword()), this.plaintextTextArea.getText());
            byte[] message = data.toString().getBytes();
            DatagramPacket packet = new DatagramPacket(message, message.length, InetAddress.getByName(this.addressTextField.getText()), Integer.valueOf(this.portSpinner.getValue().toString()));
            this.socket.send(packet);
        } catch (Exception ex) {
            Logger.getLogger(SecureUdpClientView.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_sendButtonActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel addressLabel;
    private javax.swing.JTextField addressTextField;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JPanel mainPanel;
    private javax.swing.JLabel passphraseLabel;
    private javax.swing.JPasswordField passphrasePasswordField;
    private javax.swing.JLabel plaintextLabel;
    private javax.swing.JTextArea plaintextTextArea;
    private javax.swing.JLabel portLabel;
    private javax.swing.JSpinner portSpinner;
    private javax.swing.JButton sendButton;
    // End of variables declaration//GEN-END:variables
}