<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:template match="channel">
		<h1><xsl:value-of select="title" /></h1>
			<p><a>
				<xsl:attribute name="href">
					<xsl:value-of select="link"/>
				</xsl:attribute>
				<xsl:value-of select="description" /> 
			</a></p>

			<ol>
			<xsl:for-each select="item">
				<li><a>
					<xsl:attribute name="href">
						<xsl:value-of select="link" />
					</xsl:attribute>
					<xsl:value-of select="description" />
				</a></li>
				<ol>
				<xsl:for-each select="comment">
					<li><xsl:value-of select="."/></li>
				</xsl:for-each>
				</ol>
			</xsl:for-each>
			</ol>
	</xsl:template>
</xsl:stylesheet>