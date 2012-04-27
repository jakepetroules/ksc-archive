#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    this->ui->setupUi(this);

    this->socket = new QUdpSocket(this);
    QObject::connect(this->socket, SIGNAL(readyRead()), this, SLOT(processPendingDatagrams()));

    this->ui->addressComboBox->addItem("0.0.0.0");
    QHostInfo info = QHostInfo::fromName(QHostInfo::localHostName());
    QList<QHostAddress> list = info.addresses();
    foreach (QHostAddress addr, list)
    {
        this->ui->addressComboBox->addItem(addr.toString());
    }

    this->listenerBindingChanged();
}

MainWindow::~MainWindow()
{
    delete this->ui;
}

std::string decrypt(std::string ciphertext, std::string passphrase);

void MainWindow::processPendingDatagrams()
{
    while (this->socket->hasPendingDatagrams())
    {
        QByteArray datagram;
        datagram.resize(this->socket->pendingDatagramSize());
        this->socket->readDatagram(datagram.data(), datagram.size());

        // Get string value of datagram and decrypt it
        QString str(datagram.constData());
        QString decrypted = QString::fromStdString(decrypt(str.toStdString(), this->ui->passphraseLineEdit->text().toStdString()));

        this->ui->logTextEdit->append(tr("Received datagram: \"%1\"").arg(decrypted.toUpper()));
    }
}

void MainWindow::listenerBindingChanged()
{
    QString address = this->ui->addressComboBox->currentText();
    int port = this->ui->portSpinBox->value();
    bool needsRebinding = this->socket->localAddress() != QHostAddress(address) || this->socket->localPort() != port;

    if (needsRebinding)
    {
        // If the socket is bound, it needs to be closed before it can be rebound
        if (this->socket->state() != QAbstractSocket::UnconnectedState)
        {
            this->socket->close();
        }

        // Bind to the specified address and port
        // Print a message indicating whether the socket was successfully bound to the address and port or not
        if (this->socket->bind(QHostAddress(address), port, QUdpSocket::ShareAddress))
        {
            this->ui->logTextEdit->append(tr("<font color=green>Successfully bound to %1:%2</font>").arg(address).arg(port));
        }
        else
        {
            this->ui->logTextEdit->append(tr("<font color=red>Failed to bind to %1:%2</font>").arg(address).arg(port));
        }
    }
}
