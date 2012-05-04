#!/bin/bash

ltrs=${1,,} # Optional letters
reqd=${2:-.} # Required letters - if this is not specified the variable is set to "."
cset=${ltrs} # Set of letters to use to find words

# If no args are specified, show usage
if [ -z "$ltrs" ] ; then
  echo "Usage: `basename $0` charset [required-sequence]"
  exit 1
fi

# If the optional sequence was specified, append the letters to the working character set
if [ "$reqd" != "." ] ; then
  cset=${cset}${reqd}
fi

# Build a regex command that finds all words containing our set of optional letters that are at least 3
# letters long, and find the ones that contain the required letters if they
# were specified (otherwise it will be . which will have no effect)
reg1="egrep -i \"^[$cset]{3,}$\" /usr/dict/words | grep -i $reqd "
regx=""

# Eliminates duplicates from the result set
for ((c=0; c<${#cset} ; c++ )) ; do
	tmp=${cset:$c:1}
	for ((i=0; i<${#cset} ; i++ )) ; do
	  if [ "${cset:$c:1}" == "${cset:$i:1}" ] ; then
		 tmp="$tmp.*${cset:$i:1}"
	  fi
	done
        regx="${regx}|grep -iv ${tmp}"
done

reg1="${reg1}${regx}"
#echo ${reg1} # Show the grep command used, for debugging purposes
eval ${reg1}
