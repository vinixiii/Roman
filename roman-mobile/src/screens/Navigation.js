//Packages
import React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createMaterialTopTabNavigator } from "@react-navigation/material-top-tabs";
import { SimpleLineIcons, Ionicons } from "@expo/vector-icons";

//Screens
import { Projects } from "./Projects";
import { More } from "./More";
import { Temas } from "./Themes";

//Components
import { Header } from "../components/Header";

const Tab = createMaterialTopTabNavigator();

export function Navigation() {
  return (
    <>
      <Header />
      <NavigationContainer>
        <Tab.Navigator
          tabBarPosition="bottom"
          swipeEnabled={false}
          initialRouteName="Projetos"
          tabBarOptions={{
            showIcon: true,
            indicatorStyle: {
              height: 0,
            },
            labelStyle: {
              paddingBottom: 60,
            },
            activeTintColor: "#3565A3",
            inactiveTintColor: "#c4c4c4",
            style: {
              height: 60,
            },
          }}
          screenOptions={({ route }) => ({
            tabBarIcon: ({ color }) => {
              if (route.name === "Temas") {
                return (
                  <Ionicons
                    name="ios-bookmark-outline"
                    size={24}
                    color={color}
                  />
                );
              }

              if (route.name === "Projetos") {
                return (
                  <Ionicons name="newspaper-outline" size={24} color={color} />
                );
              }

              if (route.name === "Mais") {
                return (
                  <SimpleLineIcons name="options" size={24} color={color} />
                );
              }
            },
          })}
        >
          <Tab.Screen name="Temas" component={Temas} />
          <Tab.Screen name="Projetos" component={Projects} />
          <Tab.Screen name="Mais" component={More} />
        </Tab.Navigator>
      </NavigationContainer>
    </>
  );
}
