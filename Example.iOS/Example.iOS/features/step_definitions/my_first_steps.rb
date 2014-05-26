Given /^I am on the Main Screen$/ do
  element_exists("view")
  sleep(STEP_PAUSE)
end

Then(/^I press Main_Button$/) do
  button = query('button').find_all{ |x| x["label"] =~ /.*clicks.*/ }
  touch(button)
end

Then(/^Main_Button Title will be “(\d+) clicks!”$/) do |arg1|
  result = query('button')
  puts result
  button = result.find_all{ |x| x["label"] =~ /.*clicks.*/ }
  #puts button
  #puts arg1
  expr = /.*#{arg1}.*/
  #puts expr
  #puts button[0]["label"] =~ expr
  raise "Wrong label on Main_Button" unless (button[0]["label"] =~ expr)
end