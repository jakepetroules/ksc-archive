#!/bin/sh
PHYSICAL_CD=$(dirname $0)
pushd $PHYSICAL_CD

# Create alias for Botan in the system location
BOTAN_LOCAL=$PWD/botan/libbotan-1.9.12.dylib
BOTAN_SYS=/usr/local/lib/libbotan-1.9.12.dylib
echo "Creating alias for $BOTAN_LOCAL at $BOTAN_SYS..."
sudo ln -s "$BOTAN_LOCAL" "$BOTAN_SYS"

for BUILD_DIR in "$PWD/../udp-build-desktop-"*
do
	# Run macdeployqt on UDP client
	if [ ! -f "$BUILD_DIR/udpclient/udpclient.app/Contents/Resources/qt.conf" ] ; then
		echo "Deploying client application..."
		pushd "$BUILD_DIR/udpclient"
		~/QtSDK/Desktop/Qt/4.8.0/gcc/bin/macdeployqt udpclient.app
		popd
	fi
	
	# Run macdeployqt on UDP server
	if [ ! -f "$BUILD_DIR/udpserver/udpserver.app/Contents/Resources/qt.conf" ] ; then
		echo "Deploying server application..."
		pushd "$BUILD_DIR/udpserver"
		~/QtSDK/Desktop/Qt/4.8.0/gcc/bin/macdeployqt udpserver.app
		popd
	fi
done

# Remove alias for Botan in the system location
echo "Removing alias $BOTAN_SYS"
sudo rm $BOTAN_SYS

popd