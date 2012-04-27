/*
 * DSAss03A_PetroulesJView.java
 */

package dsass03a_petroulesj;

import org.jdesktop.application.Action;
import org.jdesktop.application.ResourceMap;
import org.jdesktop.application.SingleFrameApplication;
import org.jdesktop.application.FrameView;
import org.jdesktop.application.TaskMonitor;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.Timer;
import javax.swing.Icon;
import javax.swing.JDialog;
import javax.swing.JFrame;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;
import javax.swing.event.*;
import javax.swing.table.DefaultTableModel;

/**
 * The application's main frame.
 */
public class DSAss03A_PetroulesJView extends FrameView implements TableModelListener
{
    public DSAss03A_PetroulesJView(SingleFrameApplication app) {
        super(app);
        
        initComponents();

        // status bar initialization - message timeout, idle icon and busy animation, etc
        ResourceMap resourceMap = getResourceMap();
        int messageTimeout = resourceMap.getInteger("StatusBar.messageTimeout");
        messageTimer = new Timer(messageTimeout, new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                statusMessageLabel.setText("");
            }
        });
        messageTimer.setRepeats(false);
        int busyAnimationRate = resourceMap.getInteger("StatusBar.busyAnimationRate");
        for (int i = 0; i < busyIcons.length; i++) {
            busyIcons[i] = resourceMap.getIcon("StatusBar.busyIcons[" + i + "]");
        }
        busyIconTimer = new Timer(busyAnimationRate, new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                busyIconIndex = (busyIconIndex + 1) % busyIcons.length;
                statusAnimationLabel.setIcon(busyIcons[busyIconIndex]);
            }
        });
        idleIcon = resourceMap.getIcon("StatusBar.idleIcon");
        statusAnimationLabel.setIcon(idleIcon);
        progressBar.setVisible(false);

        // connecting action tasks to status bar via TaskMonitor
        TaskMonitor taskMonitor = new TaskMonitor(getApplication().getContext());
        taskMonitor.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                String propertyName = evt.getPropertyName();
                if ("started".equals(propertyName)) {
                    if (!busyIconTimer.isRunning()) {
                        statusAnimationLabel.setIcon(busyIcons[0]);
                        busyIconIndex = 0;
                        busyIconTimer.start();
                    }
                    progressBar.setVisible(true);
                    progressBar.setIndeterminate(true);
                } else if ("done".equals(propertyName)) {
                    busyIconTimer.stop();
                    statusAnimationLabel.setIcon(idleIcon);
                    progressBar.setVisible(false);
                    progressBar.setValue(0);
                } else if ("message".equals(propertyName)) {
                    String text = (String)(evt.getNewValue());
                    statusMessageLabel.setText((text == null) ? "" : text);
                    messageTimer.restart();
                } else if ("progress".equals(propertyName)) {
                    int value = (Integer)(evt.getNewValue());
                    progressBar.setVisible(true);
                    progressBar.setIndeterminate(false);
                    progressBar.setValue(value);
                }
            }
        });

        this.populateTable();
    }

    @Action
    public void showAboutBox() {
        if (aboutBox == null) {
            JFrame mainFrame = DSAss03A_PetroulesJApp.getApplication().getMainFrame();
            aboutBox = new DSAss03A_PetroulesJAboutBox(mainFrame);
            aboutBox.setLocationRelativeTo(mainFrame);
        }
        DSAss03A_PetroulesJApp.getApplication().show(aboutBox);
    }

    public void tableChanged(TableModelEvent e)
    {
        final int NAME_COLUMN = 0;
        final int POP_COLUMN = 1;
        final int GNI_COLUMN = 2;
        final int PCI_COLUMN = 3;

        // Make sure we're handling the right table
        // (even though there's only one, this is good measure)
        if (e.getSource() != this.countriesTable.getModel() || e.getType() != TableModelEvent.UPDATE)
        {
            return;
        }

        int row = e.getFirstRow();
        DefaultTableModel model = (DefaultTableModel)e.getSource();

        try
        {
            // Remove the listener for the model so setting the PCI doesn't lead us to Stack Overflow
            model.removeTableModelListener(this);

            // Get the properties of the country from the table at this row
            Object nameObject = model.getValueAt(row, NAME_COLUMN);
            String name = nameObject != null ? nameObject.toString() : "";
            long population = Long.parseLong(String.valueOf(model.getValueAt(row, POP_COLUMN)));
            long gni = Long.parseLong(String.valueOf(model.getValueAt(row, GNI_COLUMN)));

            // Get the corresponding country from our collection
            CountryCollection countries = this.currentCollection;
            Country country = countries.size() >= row + 1 ? countries.get(row) : null;

            // Update the existing country instance
            if (country != null)
            {
                country.setName(name);
                country.setPopulation(population);
                country.setGrossNationalIncome(gni);
            }
            else
            {
                // Ensure we have space to do so...
                while (countries.size() < row + 1)
                {
                    countries.add(null);
                }

                // ...and then add the new country
                country = new Country(name, population, gni);
                countries.set(row, country);
            }

            model.setValueAt("$" + country.getPerCapitaIncome(), row, PCI_COLUMN);
        }
        catch (NumberFormatException ex)
        {
            model.setValueAt("N/A", row, PCI_COLUMN);
        }
        finally
        {
            // Put the listener back
            model.addTableModelListener(this);
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
        jScrollPane1 = new javax.swing.JScrollPane();
        countriesTable = new javax.swing.JTable();
        addRowButton = new javax.swing.JButton();
        removeRowsButton = new javax.swing.JButton();
        getStatisticsButton = new javax.swing.JButton();
        sortCheckBox = new javax.swing.JCheckBox();
        findButton = new javax.swing.JButton();
        fillWithDataButton = new javax.swing.JButton();
        countButton = new javax.swing.JButton();
        removeAllButton = new javax.swing.JButton();
        menuBar = new javax.swing.JMenuBar();
        javax.swing.JMenu fileMenu = new javax.swing.JMenu();
        javax.swing.JMenuItem exitMenuItem = new javax.swing.JMenuItem();
        javax.swing.JMenu helpMenu = new javax.swing.JMenu();
        javax.swing.JMenuItem aboutMenuItem = new javax.swing.JMenuItem();
        statusPanel = new javax.swing.JPanel();
        javax.swing.JSeparator statusPanelSeparator = new javax.swing.JSeparator();
        statusMessageLabel = new javax.swing.JLabel();
        statusAnimationLabel = new javax.swing.JLabel();
        progressBar = new javax.swing.JProgressBar();

        mainPanel.setName("mainPanel"); // NOI18N

        jScrollPane1.setName("jScrollPane1"); // NOI18N

        countriesTable.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

            },
            new String [] {
                "Country name", "Population", "Gross national income (GNI)", "Per capita income (PCI)"
            }
        ) {
            Class[] types = new Class [] {
                java.lang.String.class, java.lang.Long.class, java.lang.Long.class, java.lang.Long.class
            };
            boolean[] canEdit = new boolean [] {
                true, true, true, false
            };

            public Class getColumnClass(int columnIndex) {
                return types [columnIndex];
            }

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        countriesTable.setName("countriesTable"); // NOI18N
        jScrollPane1.setViewportView(countriesTable);
        org.jdesktop.application.ResourceMap resourceMap = org.jdesktop.application.Application.getInstance(dsass03a_petroulesj.DSAss03A_PetroulesJApp.class).getContext().getResourceMap(DSAss03A_PetroulesJView.class);
        countriesTable.getColumnModel().getColumn(0).setHeaderValue(resourceMap.getString("countriesTable.columnModel.title0")); // NOI18N
        countriesTable.getColumnModel().getColumn(1).setHeaderValue(resourceMap.getString("countriesTable.columnModel.title1")); // NOI18N
        countriesTable.getColumnModel().getColumn(2).setHeaderValue(resourceMap.getString("countriesTable.columnModel.title2")); // NOI18N
        countriesTable.getColumnModel().getColumn(3).setHeaderValue(resourceMap.getString("countriesTable.columnModel.title3")); // NOI18N

        addRowButton.setText(resourceMap.getString("addRowButton.text")); // NOI18N
        addRowButton.setName("addRowButton"); // NOI18N
        addRowButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                addRowButtonActionPerformed(evt);
            }
        });

        removeRowsButton.setText(resourceMap.getString("removeRowsButton.text")); // NOI18N
        removeRowsButton.setName("removeRowsButton"); // NOI18N
        removeRowsButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                removeRowsButtonActionPerformed(evt);
            }
        });

        getStatisticsButton.setText(resourceMap.getString("getStatisticsButton.text")); // NOI18N
        getStatisticsButton.setName("getStatisticsButton"); // NOI18N
        getStatisticsButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                getStatisticsButtonActionPerformed(evt);
            }
        });

        sortCheckBox.setText(resourceMap.getString("sortCheckBox.text")); // NOI18N
        sortCheckBox.setName("sortCheckBox"); // NOI18N
        sortCheckBox.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                sortCheckBoxActionPerformed(evt);
            }
        });

        findButton.setText(resourceMap.getString("findButton.text")); // NOI18N
        findButton.setName("findButton"); // NOI18N
        findButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                findButtonActionPerformed(evt);
            }
        });

        fillWithDataButton.setText(resourceMap.getString("fillWithDataButton.text")); // NOI18N
        fillWithDataButton.setName("fillWithDataButton"); // NOI18N
        fillWithDataButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                fillWithDataButtonActionPerformed(evt);
            }
        });

        countButton.setText(resourceMap.getString("countButton.text")); // NOI18N
        countButton.setName("countButton"); // NOI18N
        countButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                countButtonActionPerformed(evt);
            }
        });

        removeAllButton.setText(resourceMap.getString("removeAllButton.text")); // NOI18N
        removeAllButton.setName("removeAllButton"); // NOI18N
        removeAllButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                removeAllButtonActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout mainPanelLayout = new javax.swing.GroupLayout(mainPanel);
        mainPanel.setLayout(mainPanelLayout);
        mainPanelLayout.setHorizontalGroup(
            mainPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(mainPanelLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(mainPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 793, Short.MAX_VALUE)
                    .addGroup(mainPanelLayout.createSequentialGroup()
                        .addComponent(addRowButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(removeRowsButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(removeAllButton)
                        .addGap(6, 6, 6)
                        .addComponent(findButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(fillWithDataButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(countButton)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 61, Short.MAX_VALUE)
                        .addComponent(sortCheckBox)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(getStatisticsButton)))
                .addContainerGap())
        );
        mainPanelLayout.setVerticalGroup(
            mainPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, mainPanelLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 245, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(mainPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(addRowButton)
                    .addComponent(removeRowsButton)
                    .addComponent(getStatisticsButton)
                    .addComponent(sortCheckBox)
                    .addComponent(findButton)
                    .addComponent(fillWithDataButton)
                    .addComponent(countButton)
                    .addComponent(removeAllButton))
                .addContainerGap())
        );

        menuBar.setName("menuBar"); // NOI18N

        fileMenu.setText(resourceMap.getString("fileMenu.text")); // NOI18N
        fileMenu.setName("fileMenu"); // NOI18N

        javax.swing.ActionMap actionMap = org.jdesktop.application.Application.getInstance(dsass03a_petroulesj.DSAss03A_PetroulesJApp.class).getContext().getActionMap(DSAss03A_PetroulesJView.class, this);
        exitMenuItem.setAction(actionMap.get("quit")); // NOI18N
        exitMenuItem.setName("exitMenuItem"); // NOI18N
        fileMenu.add(exitMenuItem);

        menuBar.add(fileMenu);

        helpMenu.setText(resourceMap.getString("helpMenu.text")); // NOI18N
        helpMenu.setName("helpMenu"); // NOI18N

        aboutMenuItem.setAction(actionMap.get("showAboutBox")); // NOI18N
        aboutMenuItem.setName("aboutMenuItem"); // NOI18N
        helpMenu.add(aboutMenuItem);

        menuBar.add(helpMenu);

        statusPanel.setName("statusPanel"); // NOI18N

        statusPanelSeparator.setName("statusPanelSeparator"); // NOI18N

        statusMessageLabel.setName("statusMessageLabel"); // NOI18N

        statusAnimationLabel.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        statusAnimationLabel.setName("statusAnimationLabel"); // NOI18N

        progressBar.setName("progressBar"); // NOI18N

        javax.swing.GroupLayout statusPanelLayout = new javax.swing.GroupLayout(statusPanel);
        statusPanel.setLayout(statusPanelLayout);
        statusPanelLayout.setHorizontalGroup(
            statusPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(statusPanelSeparator, javax.swing.GroupLayout.DEFAULT_SIZE, 813, Short.MAX_VALUE)
            .addGroup(statusPanelLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(statusMessageLabel)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 643, Short.MAX_VALUE)
                .addComponent(progressBar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(statusAnimationLabel)
                .addContainerGap())
        );
        statusPanelLayout.setVerticalGroup(
            statusPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(statusPanelLayout.createSequentialGroup()
                .addComponent(statusPanelSeparator, javax.swing.GroupLayout.PREFERRED_SIZE, 2, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(statusPanelLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(statusMessageLabel)
                    .addComponent(statusAnimationLabel)
                    .addComponent(progressBar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(3, 3, 3))
        );

        setComponent(mainPanel);
        setMenuBar(menuBar);
        setStatusBar(statusPanel);
    }// </editor-fold>//GEN-END:initComponents

    private void addRowButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_addRowButtonActionPerformed
    {//GEN-HEADEREND:event_addRowButtonActionPerformed
        this.addRow();
    }//GEN-LAST:event_addRowButtonActionPerformed

    private void removeRowsButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_removeRowsButtonActionPerformed
    {//GEN-HEADEREND:event_removeRowsButtonActionPerformed
        this.removeRows();
    }//GEN-LAST:event_removeRowsButtonActionPerformed

    private void getStatisticsButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_getStatisticsButtonActionPerformed
    {//GEN-HEADEREND:event_getStatisticsButtonActionPerformed
        this.showStatistics();
    }//GEN-LAST:event_getStatisticsButtonActionPerformed

    private void sortCheckBoxActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_sortCheckBoxActionPerformed
    {//GEN-HEADEREND:event_sortCheckBoxActionPerformed
        this.updateSortOrder(this.sortCheckBox.isSelected());
    }//GEN-LAST:event_sortCheckBoxActionPerformed

    private void findButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_findButtonActionPerformed
    {//GEN-HEADEREND:event_findButtonActionPerformed
        this.launchFindInTable();
    }//GEN-LAST:event_findButtonActionPerformed

    private void fillWithDataButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_fillWithDataButtonActionPerformed
    {//GEN-HEADEREND:event_fillWithDataButtonActionPerformed
        this.countries.fillWithData();
        this.populateTable();
    }//GEN-LAST:event_fillWithDataButtonActionPerformed

    private void countButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_countButtonActionPerformed
    {//GEN-HEADEREND:event_countButtonActionPerformed
        String message = "";
        int size = this.countries.size();
        if (size == 0)
        {
            message = "There are no countries in the list.";
        }
        else if (size == 1)
        {
            message = "There is 1 country in the list.";
        }
        else if (size >= 2)
        {
            message = String.format("There are %1$s countries in the list.", this.countries.size());
        }

        JOptionPane.showMessageDialog(this.getComponent(), message, "Number of countries", JOptionPane.INFORMATION_MESSAGE);
    }//GEN-LAST:event_countButtonActionPerformed

    private void removeAllButtonActionPerformed(java.awt.event.ActionEvent evt)//GEN-FIRST:event_removeAllButtonActionPerformed
    {//GEN-HEADEREND:event_removeAllButtonActionPerformed
        this.countries.clear();
        this.populateTable();
    }//GEN-LAST:event_removeAllButtonActionPerformed

    /**
     * Adds a blank row to the end of the table to allow the user to enter a new country in the list.
     */
    private void addRow()
    {
        DefaultTableModel model = (DefaultTableModel)this.countriesTable.getModel();
        model.addRow(new Object[] { });
    }

    /**
     * Removes all selected rows from the country table and internal list.
     */
    private void removeRows()
    {
        DefaultTableModel model = (DefaultTableModel)this.countriesTable.getModel();
        while (this.countriesTable.getSelectedRows().length > 0)
        {
            this.countries.remove(this.countriesTable.getSelectedRow());
            model.removeRow(this.countriesTable.getSelectedRow());
        }
    }

    /**
     * Shows a dialog allowing the user to type the name of a country to highlight in the table.
     */
    private void launchFindInTable()
    {
        String response = JOptionPane.showInputDialog(this.getComponent(), "",
                "Find country by name", JOptionPane.PLAIN_MESSAGE);
        if (response != null)
        {
            int index = this.countries.indexOf(response);

            ListSelectionModel model = this.countriesTable.getSelectionModel();
            if (index > -1)
            {
                model.setSelectionInterval(index, index);
            }
            else
            {
                model.clearSelection();
                JOptionPane.showMessageDialog(this.getComponent(),
                        String.format("The country \"%1$s\" was not found in the list.", response),
                        "Country not found", JOptionPane.INFORMATION_MESSAGE);
            }
        }
    }

    /**
     * Shows statistics of the country table, including the country with the lowest PCI, the
     * country with the highest PCI, the average PCI of all countries, and the standard deviation.
     */
    private void showStatistics()
    {
        CountryCollection countries = this.currentCollection;
        if (countries.size() < 1)
        {
            JOptionPane.showMessageDialog(this.getComponent(),
                    "You must add at least one country to the list.", "Error",
                    JOptionPane.ERROR_MESSAGE);
            return;
        }

        String statistics = "";

        Country lowestPCI = countries.getLowestPCICountry();
        statistics += String.format("Country with lowest PCI: %1$s ($%2$d)\n\n", lowestPCI.getName(), lowestPCI.getPerCapitaIncome());

        Country highestPCI = countries.getHighestPCICountry();
        statistics += String.format("Country with highest PCI: %1$s ($%2$d)\n\n", highestPCI.getName(), highestPCI.getPerCapitaIncome());

        statistics += String.format("Average PCI of all countries in list: $%1$d\n\n", countries.getAveragePerCapitaIncome());
        statistics += String.format("Standard deviation: %1$d", countries.getStandardDeviation());

        JOptionPane.showMessageDialog(this.getComponent(), statistics, "Statistics", JOptionPane.INFORMATION_MESSAGE);
    }

    /**
     * Updates the sort order of the countries table.
     * @param sort <c>true</c> to show the sorted list, <c>false</c> to show the unsorted list
     */
    private void updateSortOrder(boolean sort)
    {
        this.addRowButton.setEnabled(!sort);
        this.removeRowsButton.setEnabled(!sort);
        this.removeAllButton.setEnabled(!sort);
        this.findButton.setEnabled(!sort);
        this.fillWithDataButton.setEnabled(!sort);
        this.countriesTable.setEnabled(!sort);
        this.currentCollection = sort ? this.getCountriesSorted() : this.countries;
        this.populateTable();
    }

    /**
     * Populates the countries table with the data in the current country list.
     * Any previous data in the table will be removed.
     */
    private void populateTable()
    {
        CountryCollection currentList = this.currentCollection;
        DefaultTableModel model = (DefaultTableModel)this.countriesTable.getModel();
        model.removeTableModelListener(this);
        while (model.getRowCount() > 0)
        {
            model.removeRow(0);
        }

        model.addTableModelListener(this);

        for (int i = 0; i < currentList.size(); i++)
        {
            Country c = currentList.get(i);
            if (c != null)
            {
                model.addRow(new Object[] { c.getName(), c.getPopulation(), c.getGrossNationalIncome() });
            }
            else
            {
                model.addRow(new Object[] { });
            }

            model.fireTableRowsUpdated(i, i);
        }
    }

    /**
     * Gets a copy of the countries list sorted by per capita income.
     */
    private CountryCollection getCountriesSorted()
    {
        CountryCollection sorted = new CountryCollection(this.countries);
        sorted.sortByPerCapitaIncome();
        return sorted;
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton addRowButton;
    private javax.swing.JButton countButton;
    private javax.swing.JTable countriesTable;
    private javax.swing.JButton fillWithDataButton;
    private javax.swing.JButton findButton;
    private javax.swing.JButton getStatisticsButton;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JPanel mainPanel;
    private javax.swing.JMenuBar menuBar;
    private javax.swing.JProgressBar progressBar;
    private javax.swing.JButton removeAllButton;
    private javax.swing.JButton removeRowsButton;
    private javax.swing.JCheckBox sortCheckBox;
    private javax.swing.JLabel statusAnimationLabel;
    private javax.swing.JLabel statusMessageLabel;
    private javax.swing.JPanel statusPanel;
    // End of variables declaration//GEN-END:variables

    /**
     * The list of countries in arbitrary order.
     */
    private CountryCollection countries = new CountryCollection();

    /**
     * The list of countries currently being operated on (this may be the original list or a sorted
     * copy).
     */
    private CountryCollection currentCollection = this.countries;

    private final Timer messageTimer;
    private final Timer busyIconTimer;
    private final Icon idleIcon;
    private final Icon[] busyIcons = new Icon[15];
    private int busyIconIndex = 0;

    private JDialog aboutBox;
}
