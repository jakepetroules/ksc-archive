QT += core gui network
TARGET = udpserver
TEMPLATE = app
SOURCES += main.cpp mainwindow.cpp decrypt.cpp
HEADERS += mainwindow.h
FORMS += mainwindow.ui

win32:LIBS += -luser32 -ladvapi32

win32:CONFIG(release, debug|release): LIBS += -L$$PWD/../botan/ -lbotan
else:win32:CONFIG(debug, debug|release): LIBS += -L$$PWD/../botan/ -lbotand
else:unix:!symbian: LIBS += -L$$PWD/../botan/ -lbotan

INCLUDEPATH += $$PWD/../botan/build/include
DEPENDPATH += $$PWD/../botan/build/include
