/* 
 * File:   properties.h
 * Author: jakepetroules
 *
 * Created on April 23, 2011, 9:54 PM
 */

#ifndef PROPERTIES_H
#define	PROPERTIES_H

// This macro expands to the prototypes for a getter and setter function for a variable of the given type
// Sample usage: propertydef(int, i,I,dNumber)
#define propertydef(type, v, V, ariable) type v##ariable() const; void set##V##ariable(type v##ariable)

// This macro expands to the implementations for a getter and setter function for a variable of the given type
// Sample usage: propertyimpl(int, MyClass, i,I,dNumber)
#define propertyimpl(type, classname, v, V, ariable) type classname::v##ariable() const { return this->m_##v##ariable; } void classname::set##V##ariable(type v##ariable) { this->m_##v##ariable = v##ariable; }

#endif	/* PROPERTIES_H */

