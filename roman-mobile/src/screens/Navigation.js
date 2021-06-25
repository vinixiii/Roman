//Packages
import React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createMaterialTopTabNavigator } from "@react-navigation/material-top-tabs";
import { SimpleLineIcons, Ionicons } from "@expo/vector-icons";

//Screens
import {
  MoreNavigator,
  ProjectsNavigator,
  ThemesNavigator,
} from "./StackNavigator";

const Tab = createMaterialTopTabNavigator();

export function Navigation() {
  return (
    <Tab.Navigator
      tabBarPosition="bottom"
      swipeEnabled={true}
      initialRouteName="Projects"
      tabBarOptions={{
        showIcon: true,
        indicatorStyle: {
          height: 0,
        },
        labelStyle: {
          textTransform: "none",
        },
        activeTintColor: "#3565A3",
        inactiveTintColor: "#c4c4c4",
        style: {
          height: 65,
        },
      }}
      screenOptions={({ route }) => ({
        tabBarIcon: ({ color }) => {
          if (route.name === "Themes") {
            return (
              <Ionicons name="ios-bookmark-outline" size={24} color={color} />
            );
          }

          if (route.name === "Projects") {
            return (
              <Ionicons name="newspaper-outline" size={24} color={color} />
            );
          }

          if (route.name === "More") {
            return <SimpleLineIcons name="options" size={24} color={color} />;
          }
        },
      })}
    >
      <Tab.Screen name="Themes" component={ThemesNavigator} />
      <Tab.Screen name="Projects" component={ProjectsNavigator} />
      <Tab.Screen name="More" component={MoreNavigator} />
    </Tab.Navigator>
  );
}
