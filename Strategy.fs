module Strategy

let rec sort comp  = 
  function | [] -> []
           | [x] -> [x]
           | x::xs -> let ls, gt = List.partition (comp x) xs
                      List.concat[(sort comp ls); [x]; (sort comp gt)]