#
# Generated Makefile - do not edit!
#
# Edit the Makefile in the project folder instead (../Makefile). Each target
# has a -pre and a -post target defined where you can add customized code.
#
# This makefile implements configuration specific macros and targets.


# Environment
MKDIR=mkdir
CP=cp
GREP=grep
NM=nm
CCADMIN=CCadmin
RANLIB=ranlib
CC=gcc
CCC=g++
CXX=g++
FC=gfortran
AS=as

# Macros
CND_PLATFORM=GNU-MacOSX
CND_CONF=Debug
CND_DISTDIR=dist
CND_BUILDDIR=build

# Include project Makefile
include Makefile

# Object Directory
OBJECTDIR=${CND_BUILDDIR}/${CND_CONF}/${CND_PLATFORM}

# Object Files
OBJECTFILES= \
	${OBJECTDIR}/EmpAcademicRecord.o \
	${OBJECTDIR}/EmpExtraCurricular.o \
	${OBJECTDIR}/Student.o \
	${OBJECTDIR}/Employee.o \
	${OBJECTDIR}/EmpEmploymentHistory.o \
	${OBJECTDIR}/EmpPersonalInfo.o \
	${OBJECTDIR}/CollegeMember.o \
	${OBJECTDIR}/CollegeMain.o \
	${OBJECTDIR}/EmpPublicationLog.o


# C Compiler Flags
CFLAGS=

# CC Compiler Flags
CCFLAGS=
CXXFLAGS=

# Fortran Compiler Flags
FFLAGS=

# Assembler Flags
ASFLAGS=

# Link Libraries and Options
LDLIBSOPTIONS=

# Build Targets
.build-conf: ${BUILD_SUBPROJECTS}
	"${MAKE}"  -f nbproject/Makefile-${CND_CONF}.mk ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/cprogass09b_petroulesj

${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/cprogass09b_petroulesj: ${OBJECTFILES}
	${MKDIR} -p ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}
	${LINK.cc} -o ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/cprogass09b_petroulesj ${OBJECTFILES} ${LDLIBSOPTIONS} 

${OBJECTDIR}/EmpAcademicRecord.o: EmpAcademicRecord.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/EmpAcademicRecord.o EmpAcademicRecord.cpp

${OBJECTDIR}/EmpExtraCurricular.o: EmpExtraCurricular.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/EmpExtraCurricular.o EmpExtraCurricular.cpp

${OBJECTDIR}/Student.o: Student.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/Student.o Student.cpp

${OBJECTDIR}/Employee.o: Employee.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/Employee.o Employee.cpp

${OBJECTDIR}/EmpEmploymentHistory.o: EmpEmploymentHistory.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/EmpEmploymentHistory.o EmpEmploymentHistory.cpp

${OBJECTDIR}/EmpPersonalInfo.o: EmpPersonalInfo.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/EmpPersonalInfo.o EmpPersonalInfo.cpp

${OBJECTDIR}/CollegeMember.o: CollegeMember.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/CollegeMember.o CollegeMember.cpp

${OBJECTDIR}/CollegeMain.o: CollegeMain.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/CollegeMain.o CollegeMain.cpp

${OBJECTDIR}/EmpPublicationLog.o: EmpPublicationLog.cpp 
	${MKDIR} -p ${OBJECTDIR}
	${RM} $@.d
	$(COMPILE.cc) -g -MMD -MP -MF $@.d -o ${OBJECTDIR}/EmpPublicationLog.o EmpPublicationLog.cpp

# Subprojects
.build-subprojects:

# Clean Targets
.clean-conf: ${CLEAN_SUBPROJECTS}
	${RM} -r ${CND_BUILDDIR}/${CND_CONF}
	${RM} ${CND_DISTDIR}/${CND_CONF}/${CND_PLATFORM}/cprogass09b_petroulesj

# Subprojects
.clean-subprojects:

# Enable dependency checking
.dep.inc: .depcheck-impl

include .dep.inc
