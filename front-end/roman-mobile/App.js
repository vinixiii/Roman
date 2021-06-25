import React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createStackNavigator } from "@react-navigation/stack";

import { Navigation } from "./src/screens/Navigation";
import { Login } from "./src/screens/Login";

const Stack = createStackNavigator();

export default function App() {
  return (
    <NavigationContainer>
      <Stack.Navigator headerMode="none">
        <Stack.Screen name="Login" component={Login} />
        <Stack.Screen
          name="Navigation"
          component={Navigation}
          headerMode="none"
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
}
