# StructureMapDependencyGraph

http://blog.ploeh.dk/2014/06/02/captive-dependency/

A (Transient) -> B (Singleton)

The problem with this small bit in the graph is if service B expects transient, but B itself is singleton - this means that for **B only ever sees that first instance of A that the container gives it, and ignores the following instances thereafter.** 

This becomes a huge problem when **A absolutely must be an instance per request e.g. UnitOfWork**.

