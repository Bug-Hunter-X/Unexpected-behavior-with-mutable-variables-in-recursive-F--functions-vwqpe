# F# Mutable Variable Bug in Recursive Function

This repository demonstrates a common error in F# involving mutable variables within recursive functions.  The `bug.fs` file contains code that exhibits unexpected behavior due to the improper use of mutable variables. The `bugSolution.fs` file presents a corrected version using techniques that avoid this issue and provides a more predictable outcome. 

**Problem:** The original code uses mutable variables `x` and `y` within a recursive function. The mutations within the recursive call may lead to an unpredictable final state that is not intuitive.