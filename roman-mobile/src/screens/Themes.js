//Packages
import React from "react";
import { StyleSheet, View, Text, FlatList } from "react-native";
import { LinearGradient } from "expo-linear-gradient";

//Components
// import { Header } from "../components/Header";
import { Button } from "../components/Button";

const themesList = [
  { title: "React JS", status: "Ativo" },
  { title: "API", status: "Inativo" },
];

export function Themes({ navigation }) {
  const renderItem = ({ item }) => (
    <View style={styles.theme}>
      <Text style={styles.themeText}>{item.title}</Text>
      <Text
        style={
          item.status === "Ativo"
            ? styles.themeStatus
            : styles.themeStatusInactive
        }
      >
        {item.status}
      </Text>
    </View>
  );

  return (
    <View style={styles.container}>
      {/* <Header /> */}

      <View style={styles.main}>
        <Text style={styles.title}>Temas</Text>

        <View style={styles.themesList}>
          <FlatList
            data={themesList}
            keyExtractor={(item) => item.title}
            renderItem={renderItem}
          />
        </View>
      </View>

      <LinearGradient
        colors={["rgba(246, 247, 249, 0.1)", "rgba(255, 255, 255, 1)"]}
        style={styles.footer}
      >
        <Button onPress={() => navigation.navigate("NewTheme")}>
          Adicionar projeto
        </Button>
      </LinearGradient>
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

  theme: {
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

  themeText: {
    fontSize: 18,
    color: "#33547D",
  },

  themeStatus: {
    backgroundColor: "#9CEDC0",
    color: "#429266",
    fontSize: 14,
    padding: 4,
    paddingLeft: 8,
    paddingRight: 8,
    borderRadius: 3,
  },

  themeStatusInactive: {
    backgroundColor: "#E9E9E9",
    color: "#909090",
    fontSize: 14,
    padding: 4,
    paddingLeft: 8,
    paddingRight: 8,
    borderRadius: 3,
  },

  footer: {
    position: "absolute",
    bottom: 0,
    alignSelf: "center",
    width: "100%",
  },
});
