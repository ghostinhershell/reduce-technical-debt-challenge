# This function works, but could be improved for readability and long-term maintenance.
# Your challenge: reduce technical debt without changing the output.

def messy_func(arr, val)
  r = []
  arr.each_with_index do |item, idx|
    if item.include? val
      r << item + idx.to_s
    end
  end
  puts "Result:"
  r.each { |x| puts x }
end
