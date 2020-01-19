# Blank 032: Spatial food packaging

## Challenge
How could we inform grocery shoppers on nutritional value when they make their purchasing decisions at the store?

- the average grocery store in the US carries 40.000 items
- 75% of grocery purchasing decisions are made at the store
- the primary source of infoirmation on the grocery item is its physical packaging
- physical packaging is often highlights brand and emotional value, while hides nutritional information

## Solution
Spatial packaging recognizes and replaces goods' physical packaging with one that highlight's nutritional information istead of the brand.

### Design 
- Phyisical packaging is covered by a spatial packaing experience to lower information overload, and direct attention to nutritional value
- Information density changes as a shopper gets closer to the packaging (nutritional score --> key nutritional warnings --> detailed information)
- Creatures representing key nutritional values flip the branding narrative and facilitates an emotional connection between shoppers and nutriments
- Use of standard nutritional information visualizations (nutriscore, Chilean nutritional warning standard)

### Technology
- Vuforia recognizes the product packaging (image targets)
- Nutrient data is sourced dynamically from OpenFood.org's REST API
- Vufora allowed us to target several devices with one Unity project
- Mobile AR app is ready for near term adoption
- Magic Leap AR headset based app allows for seamless grocery browsing and discovery experience
