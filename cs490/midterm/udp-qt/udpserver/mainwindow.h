#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QtGui>
#include <QtNetwork>

namespace Ui {
    class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private slots:
    void processPendingDatagrams();
    void listenerBindingChanged();

private:
    Ui::MainWindow *ui;
    QUdpSocket *socket;
};

#endif // MAINWINDOW_H
