# About "Clusterization_algorithms" project

 ## Abbreviations, terms and articles links

  ### Abbreviations

  - [UAV](https://en.wikipedia.org/wiki/Unmanned_aerial_vehicle) - *Unmanned aerial vehicle*
  - [WSN](https://en.wikipedia.org/wiki/Wireless_sensor_network) - *Wireless sensor network*
  - [TSP](https://en.wikipedia.org/wiki/Travelling_salesman_problem) - *Travelling salesman problem*

  ### Terms
  
   #### General
   
   - [Cluster analysis](https://en.wikipedia.org/wiki/Cluster_analysis)
   - 
  
   #### Clustering algorithms
   
   - [K-means](https://en.wikipedia.org/wiki/K-means_clustering)
   - [K-means++](https://en.wikipedia.org/wiki/K-means%2B%2B)
   - [Forel](https://ru.wikipedia.org/wiki/%D0%90%D0%BB%D0%B3%D0%BE%D1%80%D0%B8%D1%82%D0%BC%D1%8B_%D1%81%D0%B5%D0%BC%D0%B5%D0%B9%D1%81%D1%82%D0%B2%D0%B0_FOREL)
   
   #### Route search algorithms
   
   - [FPPWR](https://www.researchgate.net/publication/343100133_Evaluating_flight_coordination_approaches_of_UAV_squads_for_WSN_data_collection_enhancing_the_internet_range_on_WSN_data_collection)
  
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
