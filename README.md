# About "Clusterization_algorithms" project

 ## Abbreviations, terms and articles links

  ### Abbreviations

  - [UAV](https://en.wikipedia.org/wiki/Unmanned_aerial_vehicle) - *Unmanned aerial vehicle*
  - [WSN](https://en.wikipedia.org/wiki/Wireless_sensor_network) - *Wireless sensor network*
  - [TSP](https://en.wikipedia.org/wiki/Travelling_salesman_problem) - *Travelling salesman problem*

  ### Terms
  
   #### General
   
   - [Cluster analysis](https://en.wikipedia.org/wiki/Cluster_analysis)
   - [Convex hull algorithms](https://en.wikipedia.org/wiki/Convex_hull_algorithms)
   - [Gift wrapping algorithm (Jarvis march)](https://en.wikipedia.org/wiki/Gift_wrapping_algorithm)
   - []()
   #### Clustering algorithms
   
   - [K-means](https://en.wikipedia.org/wiki/K-means_clustering)
   - [K-means++](https://en.wikipedia.org/wiki/K-means%2B%2B)
   - [Forel](https://ru.wikipedia.org/wiki/%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC%D1%8B_%D1%81%D0%B5%D0%BC%D0%B5%D0%B9%D1%81%D1%82%D0%B2%D0%B0_FOREL)
   
   #### Route search algorithms
   
   - [Brute-force](https://en.wikipedia.org/wiki/Brute-force_search)
   - [Convex hull insertion](https://www2.isye.gatech.edu/~mgoetsch/cali/VEHICLE/TSP/TSP017__.HTM)
   - [Nearest neighbour](https://en.wikipedia.org/wiki/Nearest_neighbour_algorithm)
   - [Spiral route](https://www.researchgate.net/figure/Spiral-search-route-of-area-target_fig6_349545726)
   - [FPPWR]()
  
  ### References to used articles
  -
  
## Project goals and objectives

 ### Physical model of system operation
 
 We have a field with positioned sensor nodes.
 1. Detect sensors position.
 2. Create sensor network map.
 3. Clustering of nodes (according to specified parameters).
 4. Build optimal route for UAV station (according to specified parameters).
 5. Collect data from nodes.
 
### Project tasks

1. Create a node generator.
2. Create a node map.
3. Node clustering.  Algorithm comparison.
   - k-means++
   - forel
4. Route calculation. Algorithm comparison.
   With mathematical calculation:
   - Brute-force
   - Nearest neighbour
   - Convex hull insertion (by angle of rotation)
   - Spiral route
   - FPPWR
5. Process of data collection.
   1. Data transmission algorithms. Algorithm comparison.
   2. Create an energy model of the system.
   3. Create statistics.
