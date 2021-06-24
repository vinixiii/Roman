//Packages
import React from "react";
import { StyleSheet, View, Text, TouchableOpacity } from "react-native";
import { Feather, MaterialIcons } from "@expo/vector-icons";
import { LinearGradient } from "expo-linear-gradient";

//Components
// import { Header } from "../components/Header";
import { Button } from "../components/Button";

export function More({ navigation }) {
  return (
    <View style={styles.container}>
      {/* <Header /> */}

      <View style={styles.main}>
        <Text style={styles.title}>Mais</Text>

        <View>
          <TouchableOpacity
            style={styles.screen}
            onPress={() => navigation.navigate("Profile")}
          >
            <View style={styles.screenContent}>
              <Feather name="user" size={24} color="#c4c4c4" />
              <Text style={styles.screenText}>Perfil</Text>
            </View>
            <MaterialIcons name="arrow-forward-ios" size={24} color="#c4c4c4" />
          </TouchableOpacity>
          <TouchableOpacity style={styles.screen}>
            <View style={styles.screenContent}>
              <MaterialIcons name="logout" size={24} color="#c4c4c4" />
              <Text style={styles.screenText}>Sair</Text>
            </View>
            <MaterialIcons name="arrow-forward-ios" size={24} color="#c4c4c4" />
          </TouchableOpacity>
        </View>
      </View>

      {/* <LinearGradient
        colors={["rgba(246, 247, 249, 0.1)", "rgba(255, 255, 255, 1)"]}
        style={styles.footer}
      >
        <Button>
          Adicionar projeto
        </Button>
      </LinearGradient> */}
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    backgroundColor: "#F6F7F9",
    flex: 1,
  },

  main: {
    paddingLeft: 20,
    paddingRight: 20,
  },

  title: {
    fontSize: 28,
    color: "#33547D",
    marginTop: 25,
    marginBottom: 25,
  },

  screen: {
    backgroundColor: "#fff",
    borderRadius: 6,
    height: 60,
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    paddingLeft: 20,
    paddingRight: 20,
    marginBottom: 20,
  },

  screenContent: {
    flexDirection: "row",
    alignItems: "center",
  },

  screenText: {
    fontSize: 18,
    color: "#c4c4c4",
    marginLeft: 20,
  },

  footer: {
    position: "absolute",
    bottom: 0,
    alignSelf: "center",
    width: "100%",
  },
});
