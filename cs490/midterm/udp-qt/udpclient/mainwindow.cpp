#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    this->ui->setupUi(this);
    this->ui->addressComboBox->addItem("255.255.255.255");
    this->socket = new QUdpSocket(this);
}

MainWindow::~MainWindow()
{
    delete ui;
}

std::string encrypt(std::string plaintext, std::string passphrase);

void MainWindow::broadcastDatagram()
{
    QByteArray datagram = QString::fromStdString(
        encrypt(this->ui->plaintextTextEdit->toPlainText().toStdString(), this->ui->passphraseLineEdit->text().toStdString())).toUtf8();
    this->socket->writeDatagram(datagram.data(), datagram.size(),
        QHostAddress(this->ui->addressComboBox->currentText()), this->ui->portSpinBox->value());
}
