let mutable x = 0
let mutable y = 0
let rec loop x y = 
    if x > 10 then ()
    else (
        x <- x + 1; 
        y <- y + x; 
        loop x y 
    )
loop x y
printf "%d %d" x y